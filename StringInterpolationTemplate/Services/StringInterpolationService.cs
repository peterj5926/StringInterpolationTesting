using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        DateTime now = _date.Now;
        return $"{now:yyyy.MM.dd}";


    }

    public string Number03()
    {
        DateTime now = _date.Now;
        return $"Day {now:dd} of {now:MMMM}, {now:yyyy}";
    }

    public string Number04()
    {
        DateTime now = _date.Now;
        return $"Year: {now:yyyy}, Month: {now:MM}, Day: {now:dd}";
    }

    public string Number05()
    {
        DateTime now = _date.Now;
        return $"{now,10:dddd}";
    }

    public string Number06()
    {
        DateTime now = _date.Now;
        return $"{now,10:hh:mm tt}{now,10:dddd}";
    }

    public string Number07()
    {
        DateTime now = _date.Now;
        return $"h:{now:hh}, m:{now:mm}, s:{now:ss}";
    }

    public string Number08()
    {
        DateTime now = _date.Now;
        return $"{now:yyyy.MM.dd.hh.mm.ss}";
    }

    public string Number09()
    {
        var pi = Math.PI;
        return $"{pi:c2}";
    }

    public string Number10()
    {
        var pi = Math.PI;
        return $"{pi,10:n3}";
    }

    public string Number11()
    {
        DateTime now = DateTime.Now;
        string hex = $"{now:yyyy}";
        int hexd = Convert.ToInt32(hex);
        return $"{hexd:X}";
    }

    //2.2019.01.22
}
