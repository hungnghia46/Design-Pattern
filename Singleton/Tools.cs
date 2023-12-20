namespace Singleton;

public class Tools
{
    private static Tools _instance;
    private Tools(){}

    public static Tools GetInstance()
    {
       
            if (_instance == null)
            {
                _instance = new Tools();
            }

            return _instance;
    }

    public void someBusinessLogic()
    {
        // ...
    }
}