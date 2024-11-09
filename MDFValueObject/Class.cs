using FluentResults;

using MDF.Framework.Extensions.Guards;
using MDF.Framework.Extensions.Guards.GuardClauses;
using MDF.Framework.SeedWork;
using MDF.Resources.Common;

namespace $rootnamespace$;

#error Do not forget to specify the type of base class. BaseValueObject<????>, Create(???? value),.NotEmpty<????>() . Delete this line when editing is complete.
public class $safeitemrootname$ : BaseValueObject<string?>
{
	#region Constant(s)

	public const byte Minimum = 50;
public const byte Maximum = 60;

#endregion /Constant(s)

#region Constructor(s)

private $safeitemname$() // For EntityFramework
		{

		}
private $safeitemname$(string? value) : base(value)
		{
}

#endregion /Constructor(s)

#region Static Member(s)

public static Result<$safeitemname$?> Create(Result<object?> guardResult)
{

	var result = Create(guardResult.Value.ToString());
	return result;

}

public static Result<$safeitemname$?> Create(string? value)
{
	//استفاده از گارد
	var guardResult = Guard.CheckIf(value, DataDictionary.$safeitemname$)
	.NotEmpty<string>()
	.MinimumLength(Minimum)
	.MaximumLength(Maximum);

	//استفاده از Validation Result
	Result <$safeitemname$?> result = new(); // ایجاد یک نمونه از کلاس Result با نوع داده $safeitemname$

	result.WithErrors(guardResult._result.Errors);

	if (result.IsFailed) // اگر عملیات ناموفق بود
	{
		return result; // بازگشت نتیجه
	}

	var returnValue = new $safeitemname$(value); // ایجاد یک نمونه جدید از عنوان
	result.WithValue(returnValue); // تنظیم مقدار نتیجه به عنوان ایجاد شده
	return result; // بازگشت نتیجه
}

	#endregion /Static Member(s)
}