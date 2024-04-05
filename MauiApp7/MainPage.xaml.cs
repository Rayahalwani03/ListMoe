namespace MauiApp7
{
    public partial class MainPage : ContentPage
    {

        public List<StudentClass> StudentList = new List<StudentClass>();
        public MainPage()
        {
            InitializeComponent();

            StudentList.Add(new StudentClass(1, "Moe", "SE"));
            StudentList.Add(new StudentClass(2, "Potato", "Hello World!"));
            StudentList.Add(new StudentClass(3, "Panana", "AAA"));
            StudentList.Add(new StudentClass(4, "hannah", "fxjdnm"));



            Stu_List_View.ItemsSource = StudentList;

        }

        private async void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var student = e.Item as StudentClass;

            await DisplayAlert("Selected student", "Student ID: " + student.ID.ToString(), "OK");
        }

        private void ADD_BUTT_Clicked(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(STU_ID.Text, out ID);
            StudentList.Add(new StudentClass(ID, STU_NAME.Text, STU_DEPT.Text));
            Stu_List_View.ItemsSource = null;
            Stu_List_View.ItemsSource = StudentList;
        }
    }

}