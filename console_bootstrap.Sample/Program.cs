using console_bootstrap;
using ConsoleTables;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



try
{
    //get input from user
    var name = $"Please enter your name".ask();

    //write in differenct colors
    "Message here".log(); //.error(), .success(), .write()

    try
    {
        //throw an exception
        "Sample exception message".exception();
    }
    catch (Exception ex)
    {
        ex.error();

    }

    //convert string to pascal case
    "stringHere".pascal();

    //show/hide a spinner while executing task
    var func = async () =>
    {
        "Task running".log();
        Thread.Sleep(5000);
        "Task done".log();

    };
    func.spin();

    //get a node from JToken
    var json = (JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(new
    {
        field1 = new { field2 = new { field3 = "value3" } }
    }));
    json.get("field1.field2")["field3"] = "new Value";

    json.get("field1.field2")["field3"].ToString().success();


    //display tabular data
    var data = new[] { new { column1 = "Value1.1", column2 = "value1.2" }, new { column1 = "Value2.1", column2 = "value2.2" } };
    ConsoleTable.From(data).Write();

}
catch (Exception ex)
{
    ex.error();
}

