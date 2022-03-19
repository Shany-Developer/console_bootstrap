# console_bootstrap
Necessary dependencies for you to forget setup and  immediately focus on logic 


Dependencies imported -
    https://www.nuget.org/packages/ConsoleTables/
    https://www.nuget.org/packages/Colorful.Console/
    https://www.nuget.org/packages/Chiwchi.Console/
    https://www.nuget.org/packages/Pastel/
    https://www.nuget.org/packages/Newtonsoft.Json/

You can use these dependencies directly in code or use any extension method available in library.


![alt text](https://github.com/Shany-Developer/console_bootstrap/console_bootstrap.Sample/op/Output1.png?raw=true)

Extension methods -
   //get input from user
    var name = $"Please enter your name".ask();

    //write in differenct colors
    "Message here".log(); //.error(), .success(), .write()

    try
    {
        //throw an exception
        "exception message".exception();
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


Useful functions from dependencies -

    //display tabular data
    var data = new[] { new { column1 = "Value1.1", column2 = "value1.2" }, new { column1 = "Value2.1", column2 = "value2.2" } };
    ConsoleTable.From(data).Write();




