namespace Aurochses.Module.Autofac.EntityFramework
{
    /// <summary>
    /// Autofac module.
    /// </summary>
    /// <seealso cref="Module" />
    public class ModuleBase : global::Autofac.Module
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleBase"/> class.
        /// </summary>
        /// <param name="nameOrConnectionString">The database name or connection string.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public ModuleBase(string nameOrConnectionString, string schemaName)
        {
            NameOrConnectionString = nameOrConnectionString;
            SchemaName = schemaName;
        }

        /// <summary>
        /// Gets the database name or connection string.
        /// </summary>
        /// <value>The database name or connection string.</value>
        public string NameOrConnectionString
        {
            get;
        }

        /// <summary>
        /// Gets the database schema name.
        /// </summary>
        /// <value>The database schema name.</value>
        public string SchemaName
        {
            get;
        }
    }
}