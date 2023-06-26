using OneOf.Types;

namespace OneOfSut;

public class FakeHandlerTemplated
{
    public async Task<string> Handle(int evenNumber)
    {
        await Task.CompletedTask;

        if ((await ValidWhenEven(evenNumber)).HasErrors(out ErrorMessageBody error))
        {
            return error.Message;
        }
        return "Success";
    }

    private static async Task<SuccessOr<ErrorMessageBody>> ValidWhenEven(int number)
    {
        await Task.CompletedTask;
        
        if (number % 2 == 0) { return new Success(); }

        return new ErrorMessageBody("Number is not Even");
    }
}
