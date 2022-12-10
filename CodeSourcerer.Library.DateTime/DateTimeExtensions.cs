using System;

namespace CodeSourcerer.Library.DateTime;

public static class DateTimeExtensions
{
    public static System.DateTime January(this int day, int year) => new System.DateTime(year, 1, day);
}