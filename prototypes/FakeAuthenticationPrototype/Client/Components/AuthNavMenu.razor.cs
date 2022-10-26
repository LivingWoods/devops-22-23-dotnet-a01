using FakeAuthenticationPrototype.Client.Shared;
using Microsoft.AspNetCore.Components;

namespace FakeAuthenticationPrototype.Client.Components;

public partial class AuthNavMenu
{
    [Inject] FakeAuthenticationProvider? FakeAuthenticationProvider { get; set; }

    void LoginAsVisitor()
    {
        FakeAuthenticationProvider?.ChangeAuthenticationState(FakeAuthenticationProvider.Visitor);
    }
    void LoginAsTrainee()
    {
        FakeAuthenticationProvider?.ChangeAuthenticationState(FakeAuthenticationProvider.Trainee);
    }
    void LoginAsTrainer()
    {
        FakeAuthenticationProvider?.ChangeAuthenticationState(FakeAuthenticationProvider.Trainer);
    }
}