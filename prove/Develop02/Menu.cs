// class Menu
// {
//     private string _title;

//     private string _description;

//     private string[] _menuItem ={
//         "1. New Journal Entry",
//         "2. Display Journal",
//         "3. Read Journal from File",
//         "4. Write Journal to File",
//         "5. Quit",
//     };

//     public Menu(string title, string description)
//     {
//         _title = title;
//         _description = description;
//     }

//     public int DisplayTitle()
//     {
//         foreach(string menu in _menuItem)
//         {
//             Console.WriteLine($"{menu}");
//         }
//         Console.Write("> ");
//         int response = int.Parse(Console.ReadLine());

//         return response;
//     }
// }