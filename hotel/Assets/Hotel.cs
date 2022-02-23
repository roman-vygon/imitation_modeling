using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Part
{
    public string name;
    public System.Func<float, float> post_function;
    public System.Func<float, string> display_func;
    public Part(string _name, System.Func<float, float>  _post_function, System.Func<float, string> _display_func)
    {
        name = _name;
        post_function = _post_function;
        display_func = _display_func;
    }
}
class Connection
{
    public string from;
    public string to;
    public System.Func<float,float, float> function;
    public Connection(string _from, string _to, System.Func<float,float, float> _function)
    {
        from = _from;
        to = _to;
        function = _function;
    }
}


public class Hotel : MonoBehaviour
{
    float lastUpdate;
    static public float positiveInt(float x)
    {
        if (x < 0)
        {
            x = 0;
        }
        return Mathf.Ceil(x);
    }
    static public float positive(float x)
    {
        if (x < 0)
        {
            x = 0;
        }
        return x;
    }

    static public float fiveStar(float x)
    {
        return Mathf.Clamp(x, 0, 5);
    }

    List<Connection> connections = new List<Connection>();
    Dictionary<string, Part> parts = new Dictionary<string, Part>{
        { "wealth", new Part("wealth", x => x, x => Convert.ToString(x)) },
        {"revenue", new Part("revenue", positive, x => Convert.ToString(x)) },
        {"price",new Part("price", positive, x => Convert.ToString(x)) },
        {"budget",new Part("budget", x => x, x => Convert.ToString(x))},
        {"rating",new Part("rating", fiveStar, x => Convert.ToString(x))},
        {"quantity",new Part("quantity", positiveInt, x => Convert.ToString(x))},
        {"happiness",new Part("happiness", x => x, x => Convert.ToString(x))},
        {"communal",new Part("communal", positive, x => Convert.ToString(x))},
        {"quality",new Part("quality", x => x, x => Convert.ToString(x))},
        {"time",new Part("time", positiveInt, x => Convert.ToString(x))},
        {"personnel",new Part("personnel", positiveInt, x => Convert.ToString(x) + " ч") }};
    Dictionary<string, float> values = new Dictionary<string, float>();
    
    // Start is called before the first frame update
    void Start()
    {
        lastUpdate = Time.time;
        values["wealth"] = 2;
        values["rating"] = 1;
        values["quantity"] = 100;
        values["budget"] = 1000000;
        values["quality"] = 30;
        connections.Add(new Connection("wealth", "revenue", (x, y) => x*150));
        
        
        
        connections.Add(new Connection("rating", "revenue", (x, y) => y+1000*x));
        connections.Add(new Connection("revenue", "price", (x, y) => x / 4));
        connections.Add(new Connection("rating", "quantity", (x, y) => y+3*x));

        connections.Add(new Connection("happiness", "rating", (x, y) => x/50));
        connections.Add(new Connection("happiness", "time", (x, y) => (21*x)/2500));

        connections.Add(new Connection("quality", "happiness", (x, y) => 3.2f*x));
        connections.Add(new Connection("quality", "communal", (x, y) => x *10));        

        

        connections.Add(new Connection("personnel", "budget", (x, y) => y-200*x));
        
        connections.Add(new Connection("quantity", "personnel", (x, y) => 3*x));
        connections.Add(new Connection("quantity", "communal", (x, y) => y+x*x*2));
        connections.Add(new Connection("communal", "budget", (x, y) => y - x));

        connections.Add(new Connection("price", "quantity", (x, y) => y+10/(x)));
        

        connections.Add(new Connection("time", "quantity", (x, y) => y-y/x));


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastUpdate > 0.1)
        {
            float mem = values["budget"];
            lastUpdate = Time.time;
            Dictionary<string, float> values_copy = values;
            foreach (Connection c in connections)
            {
                values_copy.TryGetValue(c.from, out float value_from);
                values_copy.TryGetValue(c.to, out float value_to);
                values[c.to] = parts[c.to].post_function(c.function(value_from, value_to));
            }
            values["budget"] += values_copy["quantity"] * values_copy["price"];
            if (values["budget"] - mem > -10000)
            {
                values["quality"] += Mathf.Log10(values["budget"]) / 3;
            }
            else
            {
                values["quality"] -= Mathf.Log10(values["budget"]) * 2;
            }
            foreach (string name in parts.Keys)
            {
                Text val = GameObject.Find(name + "Value").GetComponent<Text>();
                if (val is null)
                    Debug.Log(name);
                val.text = parts[name].display_func(values[name]);
            }
        }
    }
}
