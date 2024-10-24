using InstitutoServices.Models.Login;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace InstitutoWeb.Services.Login
{
    public class FirebaseAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string UserIdKey = "firebaseUserId";
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


        public async Task<FirebaseUser?> GetUserAuthenticated()
        {
            var user= await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.getUserFirebase");
            //chequeo que el usuario haya verificado su correo
            if (user != null && user.EmailVerified)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> SendPasswordResetEmail(string email)
        {
            return await _jsRuntime.InvokeAsync<bool> ("firebaseAuth.sendPasswordResetEmail", email);
        }
    }
}
