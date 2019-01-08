# VSTest JSON issue repro case

This repo contains a repro case for an issue found in `dotnet test`.

When you set the `JsonConvert.DefaultSettings` to have a snake-case naming strategy, `dotnet test` will hang indefinetely.

[vstest](https://github.com/Microsoft/vstest/) uses Newtonsoft.Json, but it doesn't explicity set its serialization settings.
When code running inside that domain sets the serialization settings it breaks the communciation between the vstest host and
the actual test runner because all communication is using a JSON protocol.