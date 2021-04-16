// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using osu.Framework.Allocation;
using Vignette.Game.IO;

namespace Vignette.Game
{
    public class VignetteGame : VignetteGameBase
    {
        private UserResources resources;

        private DependencyContainer dependencies;

        protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
            => dependencies = new DependencyContainer(base.CreateChildDependencies(parent));

        public VignetteGame()
        {
            Name = @"Vignette";
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            dependencies.CacheAs(resources = new UserResources(Host, Storage));
        }

        protected override void Dispose(bool isDisposing)
        {
            base.Dispose(isDisposing);
            resources?.Dispose();
        }
    }
}