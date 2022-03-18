using console_bootstrap;

try
{
    var name = $"Please enter your name".ask();
}
catch (Exception ex)
{
    ex.error();
}

