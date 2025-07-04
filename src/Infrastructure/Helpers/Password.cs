﻿
using MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Application.Common.Interfaces;

namespace MATA.Technologies.Jake.Duldulao.Test.Weather.Application.Infrastructure.Helpers;
public class Password : IPassword
{
    public async Task<string> GeneratePasswordAsync(int lowercase, int uppercase, int numerics)
    {
        return await Task.Run(() => GeneratePassword(lowercase, uppercase, numerics));
    }

    public string GeneratePassword(int lowercase, int uppercase, int numerics)
    {
        string lowers = "abcdefghijklmnopqrstuvwxyz";
        string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string number = "0123456789";

        Random random = new Random();

        string generated = "!";
        for (int i = 1; i <= lowercase; i++)
            generated = generated.Insert(
                random.Next(generated.Length),
                lowers[random.Next(lowers.Length - 1)].ToString()
            );

        for (int i = 1; i <= uppercase; i++)
            generated = generated.Insert(
                random.Next(generated.Length),
                uppers[random.Next(uppers.Length - 1)].ToString()
            );

        for (int i = 1; i <= numerics; i++)
            generated = generated.Insert(
                random.Next(generated.Length),
                number[random.Next(number.Length - 1)].ToString()
            );

        return generated.Replace("!", string.Empty);

    }
}
