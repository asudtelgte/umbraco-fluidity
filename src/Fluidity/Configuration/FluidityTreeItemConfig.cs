using System;

namespace Fluidity.Configuration
{
    public abstract class FluidityTreeItemConfig
    {
        protected string _alias;
        internal string Alias => _alias;

        protected string _color;
        internal string Color => _color;

        protected string _parentAlias;
        internal string ParentAlias => _parentAlias;

        protected string _parentPath;
        internal string ParentPath => _parentAlias;

        protected string _path;
        internal string Path => _path;

        internal void UpdatePaths(string parentPath)
        {
            _parentPath = parentPath;

            var seperatorIndex = _parentPath.LastIndexOf(FluidityConstants.PATH_SEPERATOR, StringComparison.InvariantCulture);
            _parentAlias = seperatorIndex >= 0 ? _parentPath.Substring(seperatorIndex + FluidityConstants.PATH_SEPERATOR.Length) : _parentPath;

            _path = _parentPath + FluidityConstants.PATH_SEPERATOR + _alias;
        }
    }
}