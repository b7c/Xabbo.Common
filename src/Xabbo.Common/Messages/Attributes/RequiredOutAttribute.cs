﻿using System;

namespace Xabbo.Messages;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public sealed class RequiredOutAttribute : IdentifiersAttribute
{
    public RequiredOutAttribute(params string[] identifiers)
      : base(Destination.Server, identifiers)
    { }
}
