using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace BuggyTasks.Views;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();
        LoadDeviceInfo();
    }

    private void LoadDeviceInfo()
    {
        ModelLabel.Text = $"Model: {DeviceInfo.Model}";
        PlatformLabel.Text = $"Platform: {DeviceInfo.Platform}";
        VersionLabel.Text = $"Version: {DeviceInfo.VersionString}";
        ManufacturerLabel.Text = $"Manufacturer: {DeviceInfo.Manufacturer}";
        NameLabel.Text = $"Name: {DeviceInfo.Name}";
        DeviceTypeLabel.Text = $"Device Type: {DeviceInfo.DeviceType}";
    }
}