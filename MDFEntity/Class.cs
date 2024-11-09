using FluentResults;

using MDF.Framework.SeedWork;
using MDF.Resources.Common;
using MDF.Resources.Common.FormattedMessages;

namespace $rootnamespace$;

#error Delete this line when editing is complete.
public class $safeitemrootname$ : Entity
{
	#region Property(s)

	//ValueObject(s) here
	public ValueObject Name { get; private set; }

#endregion /Property(s)

#region Constructor(s)

private $safeitemname$() // For EntityFramework
	{

	}
private $safeitemname$(ValueObject name) : this()
	{
	Name = name;

}

#endregion /Constructor(s)

#region Static Member(s)

public static Result<$safeitemname$> Create(string? name)
{
	Result <$safeitemname$> result = new();



	var valueObjectResult = ValueObject.Create(name);
	result.WithErrors(valueObjectResult.Errors);

	if (result.IsFailed)
	{
		return result;
	}

	var returnValue = new $safeitemname$(valueObjectResult.Value);
	result.WithValue(returnValue);
	return result;
}

	#endregion /Static Member(s)
}