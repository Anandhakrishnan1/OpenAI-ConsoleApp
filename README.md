# OpenAI-ConsoleApp

# Packages required

	• OpenAI
	• OpenAI-Dotnet
	

# Implementation

	• Step 1 : Set Up Your .NET C# Project
	• Step 2 : Install the packages from NPM
	• Step 3 : Configure OpenAI API Key
	• Step 4 : Implement code (service) to use OpenAI API
	• Step 5 : use the service in your application.
	• Step 6: Run your application.


# Step 1

	Create a new .NET C# project: You can do this using Visual Studio or the .NET CLI.
		• Using the CLI: dotnet new console -n OpenAIIntegration


# Step 2

	Install the OpenAI .NET SDK: You can use the NuGet package manager to install the OpenAI-DotNet library.
		• In the NuGet Package Manager Console: Install-Package OpenAI-DotNet
		• In the NuGet Package Manager Console: Install-Package OpenAI
	
# Step 3

	• Obtain your API key: Sign up or log in to the OpenAI platform and get your API key from the dashboard.
	
	• Store your API key: For security, you should store your API key in a configuration file, environment variable, or a secure secrets manager.

		○ Using environment variables:
	

			`var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");`
			

			§ Set Environment Variable Temporarily (for the current session): Open Command Prompt and run:
			
				□ set OPENAI_API_KEY="your-api-key-here"
			
			§ This will set the environment variable for the current session.
			


			§ Set Environment Variable Permanently:
				1. Open the Start menu and search for "Environment Variables."
				2. Click "Edit the system environment variables."
				3. In the System Properties window, click "Environment Variables."
				4. Under "User variables" or "System variables," click "New..."
				5. Set OPENAI_API_KEY as the variable name and your API key as the value.
				6. Click "OK" to save.
			
			
		○ Using a configuration file (e.g., appsettings.json):
	
		
			{
			  "OpenAI": {
			    "ApiKey": "your-api-key-here"
			  }
			}
			

# Step 4

	Create a service class to interact with API. Here it is OpenAIService.

# Step 5

	Use the service in your application. Here in the main file, I called the service to get the data.


