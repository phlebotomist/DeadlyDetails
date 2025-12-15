using System;
using System.Linq;
using VampireCommandFramework;
namespace DeadlyDetails;

public class Commands
{
    [Command("DeadlyDetails", shortHand: "dd")]
    public void TestCommand(ChatCommandContext ctx)
    {
        ctx.Reply("deadlydetails running");
        return;
    }
}
