using resume_builder.models;

namespace TestResumeBuilder;

[TestFixture]
public abstract class DatabaseTest
{
	protected const string BackupResumeSqliteFileName = "backup_resume.sqlite";
	internal const string ResumeSqliteFileName = "resume.sqlite";
	protected internal Database Database { get; set; } = new();

	[TearDown]
	public void DeleteDatabase()
	{
		Cleanup();
		if(File.Exists(ResumeSqliteFileName))
			try
			{
				File.Delete(ResumeSqliteFileName);
			}
			catch(IOException e)
			{
				Assert.Warn(e.Message);
			}
		else
			Assert.Warn("Database file not found/deleted");
	}

	[SetUp]
	public virtual void SetupDatabase() => Database = new Database();

	[TearDown]
	public void DisposeDatabase()
	{
		Database.Dispose();
		Cleanup();
	}

	private static void Cleanup()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}
}