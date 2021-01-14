# The issue displayed in this repo

If you're developing an application where C# 8.0's null-reference type (NRT) feature enabled while using external libraries or references to other projects that have not been developed with this feature enabled, the compiler will not warn you about the use of objects returned from said libraries.

In the sample app here `LegacyLibrary` does **not** have NRT enabled and allows returning null from `PersonFactory.CreatePerson` if either the first or last name are null/whitespace or if the given age is below 0. Because `NrtEnabledProject` has NRT enabled, I would expect to get a warning if I try to dereference the return value from `CreatePerson`. The signature of the method `GetUserInfo` says it returns a non-nullable `Person`, however, because of using the factory from the `LegacyLibrary` this "promise" is broken and you will have a false trust in what `GetUserInfo` returns.

You can confirm this by entering an age of "-1" which will cause a null-reference exception to be thrown.