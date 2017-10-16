using Xunit;

namespace Aurochses.Module.Autofac.EntityFramework.Tests
{
    public class ModuleBaseTests
    {
        private const string NameOrConnectionString = "Database";
        private const string SchemaName = "dbo";

        private readonly ModuleBase _moduleBase;

        public ModuleBaseTests()
        {
            _moduleBase = new ModuleBase(NameOrConnectionString, SchemaName);
        }

        [Fact]
        public void Inherit_Module()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<global::Autofac.Module>(_moduleBase);
        }

        [Fact]
        public void NameOrConnectionString_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(NameOrConnectionString, _moduleBase.NameOrConnectionString);
        }

        [Fact]
        public void SchemaName_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(SchemaName, _moduleBase.SchemaName);
        }
    }
}