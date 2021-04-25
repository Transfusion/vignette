// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using osu.Framework.Graphics;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Graphics.UserInterface;

namespace Vignette.Game.Graphics.UserInterface
{
    public class FluentContextMenuContainer : ContextMenuContainer
    {
        protected override Menu CreateMenu() => new FluentMenu(Direction.Vertical);
    }
}
