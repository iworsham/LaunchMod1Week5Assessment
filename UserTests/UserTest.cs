namespace UserNamespace
{
    public class UserTest
    {
        [Fact]
        public void IsCreated_With_CorrectProperties()
        {
            User user1 = new User("Isiah", "15iworsham@gmail.com");
            Assert.Equal("Isiah", user1.Name);
            Assert.Equal("15iworsham@gmail.com", user1.Email);

        }
        [Fact]
        public void User_IsSetupComplete_CreatesAccount()
        {
            User user1 = new User("Isiah", "15iworsham@gmail.com");
            //var password = "password";
         
            user1.IsSetupComplete();
            Assert.True(true, user1.Name);
            Assert.True(true, user1.Email);

        }
        [Fact]
        public void User_CreatePassword_CreatesPassword()
        {
            User user1 = new User("Isiah", "15iworsham@gmail.com");
            user1.CreatePassword("15iworsham@gmail.com", "password");

            Assert.Equal("password", user1.Password);
        }
        [Fact]
        public void User_LogIn_LogIn()
        {
            User user1 = new User("Isiah", "15iworsham@gmail.com");
         
            Assert.Equal("Not Logged In", user1.LogIn("password"));
        }
        [Fact]
        public void User_LogOut()
        {
            User user1 = new User("Isiah", "15iworsham@gmail.com");
            user1.LogOut();
            Assert.False(user1.IsLoggedIn);
        }

    }
}