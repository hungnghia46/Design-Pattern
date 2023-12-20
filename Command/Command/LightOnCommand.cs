// Lớp LightOnCommand thực hiện giao diện ICommand và chứa tham chiếu đến đèn để thực hiện lệnh bật đèn.

using Command;

public class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}