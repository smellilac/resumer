using System.ComponentModel;
using Spectre.Console.Cli;

namespace resume_builder.cli.commands.get;

public class GetCommandSettings : CommandSettings
{
	[CommandOption("-p|--plain")]
	[Description("output in plain text")]
	[DefaultValue(false)]
	public bool Plain { get; set; }

	[CommandOption("-x|--expand")]
	[Description("output in expanded format")]
	[DefaultValue(false)]
	public bool Expand { get; set; }
}