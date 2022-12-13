using Microsoft.AspNetCore.Mvc;

public class TestController: Controller
{
    public IActionResult Action1(int num)
    {
        return View(num);
    }

    public IActionResult MultiplicationTable(int upto)
    {
        return View(upto);
    }
}
