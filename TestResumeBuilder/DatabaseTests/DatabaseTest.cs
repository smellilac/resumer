using NUnit.Framework.Internal;
using resume_builder;
using resume_builder.models;

namespace TestResumeBuilder;

[TestFixture]
public abstract class DatabaseTest
{
	protected const string BackupResumeSqliteFileName = "backup_resume.sqlite";
	internal const string ResumeSqliteFileName = "resume.sqlite";
	protected internal Database? Database { get; set; }

	[SetUp]
	public void InitDatabase()
	{
		Database = new Database();
	}

	[TearDown]
	public void DisposeDatabase()
	{
		Database.Dispose();
		Database = null;
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}
}