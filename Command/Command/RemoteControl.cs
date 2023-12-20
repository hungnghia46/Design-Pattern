// Lớp RemoteControl đóng vai trò người gọi, giữ một đối tượng ICommand và khiến nó thực hiện một hành động.

namespace Command;

public class RemoteControl
{
    private ICommand command;

    // Thiết lập lệnh cho remote control.
    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    // Nhấn nút trên remote control để thực hiện lệnh.
    public void PressButton()
    {
        command.Execute();
    }
}