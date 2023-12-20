// Lớp Light đóng vai trò người nhận, thực hiện các hành động thật sự của lệnh.
namespace Command;
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light On");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light Off");
    }
}