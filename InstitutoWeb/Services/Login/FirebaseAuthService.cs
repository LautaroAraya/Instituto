using InstitutoServices.Models.Login;
using Microsoft.JSInterop;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

namespace InstitutoWeb.Services.Login
{
    public class FirebaseAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string UserFirebase = "firebaseUser";
        public event Action OnChangeLogin;

        public FirebaseAuthService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<FirebaseUser> LoginWithGoogle()
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithGoogle");

            if (user != null)
            {
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<FirebaseUser> LoginWithFacebook()
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithFacebook");

            if (user != null)
            {
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<LoginResponse> SignInWithEmailPassword(string email, string password, bool rememberPassword)
        {

                var response = await _jsRuntime.InvokeAsync<LoginResponse>("firebaseAuth.signInWithEmailPassword", email, password, rememberPassword);
            OnChangeLogin?.Invoke();

            return response;

        }

        public async Task<string> createUserWithEmailAndPassword(string email, string password, string displayName)
        {
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.createUserWithEmailAndPassword", email, password, displayName);
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithGoogle");

            if (user != null)
            {

                await _jsRuntime.InvokeVoidAsync("localStorageHelper.setItem", UserIdKey, user);
                OnChangeLogin?.Invoke();
            }
            return user;
        }
        public async Task<FirebaseUser> SignInWithEmailPassword(string email, string password, bool rememberPassword)
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.signInWithEmailPassword", email, password);
            if (user.EmailVerified == false)
            {
                return user;

            }

            if( user != null)

            {  if (rememberPassword)
                {
                    await _jsRuntime.InvokeVoidAsync("localStorageHelper.setItem", UserIdKey, user);
                    
                }
                else
                {
                    await _jsRuntime.InvokeVoidAsync("sessionStorageHelper.setItem", UserIdKey, user);
                }
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<string> createUserWithEmailAndPassword(string email, string password)
        {
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.createUserWithEmailAndPassword", email, password);
            return userId;
        }
            public async Task SignOut()
        {
            await _jsRuntime.InvokeVoidAsync("firebaseAuth.signOut");
            await _jsRuntime.InvokeVoidAsync("localStorageHelper.removeItem", UserIdKey);
            OnChangeLogin?.Invoke();
        }

        public async Task<string> GetUserId()
        {
            return await _jsRuntime.InvokeAsync<string>("localStorageHelper.getItem", UserIdKey);
        }

        public async Task<bool> IsUserAuthenticated()
        {
            var userId = await GetUserId();
            return !string.IsNullOrEmpty(userId);
        }

    }
}
