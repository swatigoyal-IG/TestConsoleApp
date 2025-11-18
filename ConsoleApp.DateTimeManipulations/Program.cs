// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("****** Date Time Manipulations *******");

//Empty DateTime object
DateTime dateTime = new DateTime();

//Create a DateTime from date and time
//var dateOfBirth = new DateTime(1978, 5, 3);
//Console.WriteLine($"My DOB is: {dateOfBirth}");
//var exactDateAndTimeOfBirth = new DateTime(1978, 5, 3,12, 24, 30, DateTimeKind.Local);
//Console.WriteLine($"My exact DOB is: {exactDateAndTimeOfBirth}");
//Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
//Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
//Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
//Console.WriteLine($"Ticks: {exactDateAndTimeOfBirth.Ticks}");
//Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");
////Create a DateTime from current timestamp
DateTime now = DateTime.Now;
//Console.WriteLine($"Time now is: {now}");

////Create a DateTime from a string
//Console.WriteLine("Please enter your DoB (dd/MM/yyyy");
//string dobString = Console.ReadLine();
//DateTime userDob = DateTime.Parse(dobString);
//Console.WriteLine($"My DOB is: {userDob}");
//Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
//Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
//Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
//Console.WriteLine($"Ticks: {userDob.Ticks}");
//Console.WriteLine($"Kind: {userDob.Kind}");

//// Change Format DateTime
//Console.WriteLine($"Formatted DoB: {userDob.ToString("dd(ddd)/MM(MMM)/yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("MMM, dd-yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd-MMM-yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob:dddd-MMMM-yyyy}");

////Add Additional Time
//Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
//Console.WriteLine($"One hour ago from now is: {now.AddHours(-1)}");
//Console.WriteLine($"One day from now is: {now.AddDays(1)}");
//Console.WriteLine($"One day ago from now is: {now.AddDays(-1)}");

//Ticks from DateTime

//Console.WriteLine("****** - DateTime Offset manipulation - *******");
//UTC Coordinated Universal time
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Data Time: {now}");
Console.WriteLine($"UTC Now Date Time: {utcNow}");

//DateTimeOffset and TimeZone info
TimeSpan tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"User Time Zone {tz}");
DateTimeOffset dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");
TimeZoneInfo indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
Console.WriteLine($"India TimeZone: {indiaTz}");
DateTime indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

//Console.WriteLine("****** - DateOnly and TimeOnly manipulation - *******");

//DateOnly
DateOnly dateOnly = new DateOnly(1978, 05, 03);
DateOnly nextDay =dateOnly.AddDays(1);
DateOnly previousDay = dateOnly.AddDays(-1);
DateOnly decadeLater = dateOnly.AddYears(10);
DateOnly lastMonth = dateOnly.AddMonths(-1);
Console.WriteLine($"Date: {dateOnly}");
Console.WriteLine($"Next Day: {nextDay}");
Console.WriteLine($"Previous Day: {previousDay}");
Console.WriteLine($"Decade Later: {decadeLater}");
Console.WriteLine($"Previous Month: {lastMonth}");
DateOnly date = DateOnly.FromDateTime(now);
Console.WriteLine($"Date from DateTime object: {date}");
Console.WriteLine("What is your DOB (dd MMM yyyy): ");
string dobDateOnly = Console.ReadLine();
DateOnly theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"The Date Only: {theDateOnly}");
//TimeOnly
TimeOnly timeNow = TimeOnly.FromDateTime(now);
Console.WriteLine($"It is now {timeNow}");
Console.WriteLine($"It is now {timeNow:hh:mm tt}");

//Date Comparisons
DateTime date1 = new DateTime(1978, 2, 2);
DateTime date2 = new DateTime(1979, 5, 3);
if (date1 == date2 || date1.Equals(date2))
    Console.WriteLine($"{nameof(date1)}({date1}) is equal to {nameof(date2)}({date2})");
Console.WriteLine($"Is {nameof(date1)} after? {date1 > date2}");
Console.WriteLine($"Is {nameof(date1)} before? {date1 < date2}");