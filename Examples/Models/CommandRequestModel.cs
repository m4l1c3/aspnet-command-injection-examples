using Examples.Attributes;
using Examples.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Examples.Models
{
  public class CommandRequestModel
  {
    [DisplayName("Command")]
    [Required(AllowEmptyStrings = false)]
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    [EnumDataType(typeof(CommandEnum), ErrorMessage = "Invalid command")]
    public string Command { get; set; }

    [DisplayName("Arguments")]
    [Required(AllowEmptyStrings = true, ErrorMessage = "Command Arguments are required.")]
    [SafeCommand(ErrorMessage = "Invalid input, control characters are disallowed")]
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public string Arguments { get; set; }

    
    public SecurityLevelEnum SecurityLevel { get; set; }
  }
}