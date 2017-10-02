using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Examples.Attributes
{
  public class SafeCommandAttribute : ValidationAttribute
  {
    public string Expression { get; set; } = @"[&;`^\/\\]";
    
    public override bool IsValid(object value)
    {
      if (!Regex.IsMatch((string)value, this.Expression))
        return true;

      return false;
    }
  }
}