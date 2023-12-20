// Lớp LightOffCommand thực hiện giao diện ICommand và chứa tham chiếu đến đèn để thực hiện lệnh tắt đèn.
namespace Command;
public class LightOffCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.TurnOff();
    }
}