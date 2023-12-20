namespace Command;
// Chương trình chính thực hiện ví dụ sử dụng mẫu thiết kế Command.
class Program
{
    static void Main()
    {
        Light light = new Light();
        ICommand turnOnCommand = new LightOnCommand(light);
        ICommand turnOffCommand = new LightOffCommand(light);

        RemoteControl remoteControl = new RemoteControl();
        
        // Thiết lập lệnh bật đèn và thực hiện.
        remoteControl.SetCommand(turnOnCommand);
        remoteControl.PressButton();

        // Thiết lập lệnh tắt đèn và thực hiện.
        remoteControl.SetCommand(turnOffCommand);
        remoteControl.PressButton();
    }
}