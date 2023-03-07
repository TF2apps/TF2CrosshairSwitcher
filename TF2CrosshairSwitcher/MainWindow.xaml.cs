namespace TF2CrosshairSwitcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var test = new WeaponList();

            var test1 = test.scoutPrimary[0];
            var test2 = test.scoutPrimary[1];
            var test3 = test.scoutPrimary[2];

            System.Console.WriteLine("{0}, {1}, {2}", test1, test2, test3);

            var newstring = test.folderLocation + @"\" + test1;

            System.Console.WriteLine(newstring);

            // So I could re-name the list items into whatever I plan on making the VMT files
            // and then I can concatenate a string like above and use this to write a new file
        }
    }
}