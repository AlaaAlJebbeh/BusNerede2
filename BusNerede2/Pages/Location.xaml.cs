using Microsoft.Maui.Controls;

namespace BusNerede2
{
    public partial class Location : ContentPage
    {
        public Location()
        {
            InitializeComponent();
            ChildrenPicker.SelectedIndexChanged += OnPickerSelectedIndexChanged;
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected child
            string selectedChild = ChildrenPicker.SelectedItem as string;

        

            // Update the UI or navigate based on the selection
            // For example:
             if (selectedChild == "Mohammed Homsi") {
                childImage.Source = "childee.png";
                bus.Source = "arrived.png";
                note.Text = "Arrived Safely";
                note.TextColor = Color.FromRgb(0, 255, 0);
                dep.Text = "15:00";
                arr.Text = "17:00";
            }
             else if (selectedChild == "Yasmeen Homsi") {
                childImage.Source = "childee2.png";
                bus.Source = "otw.png";
                note.Text = "On the Way!Stuck in Traffic";
                note.TextColor = Color.FromRgb(255, 165, 0);
                dep.Text = "15:00";
                arr.Text = "-";
            }
             else if (selectedChild == "Majed Homsi") {
                childImage.Source = "childee3.png";
                bus.Source = "nobus.png";
                note.Text = "Did not Attend";
                note.TextColor = Color.FromRgb(255, 0, 0);
                dep.Text = "-";
                arr.Text = "-";
            }
        }
    }
}
