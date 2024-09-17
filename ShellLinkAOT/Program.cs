// See https://aka.ms/new-console-template for more information

using Vanara.Windows.Shell;

var shellLink = ShellLink.Create(
    $"{Environment.GetFolderPath(Environment.SpecialFolder.Programs)}\\1.lnk",
    $"{Environment.GetFolderPath(Environment.SpecialFolder.Programs)}\\1.lnk",null);
Console.WriteLine("Hello, World!");