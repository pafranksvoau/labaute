// Define a method to configure the request timeout
public static void ConfigureRequestTimeout(HttpWebRequest request, int timeoutInMilliseconds)
{
    if (request == null)
    {
        throw new ArgumentNullException(nameof(request), "The request cannot be null.");
    }

    if (timeoutInMilliseconds < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(timeoutInMilliseconds), "The timeout cannot be negative.");
    }

    // Set the timeout for the request
    request.Timeout = timeoutInMilliseconds;
}

// Usage
try
{
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://example.com");
    
    // Set a configurable timeout for the request (5000 milliseconds in this case)
    ConfigureRequestTimeout(request, 5000);

    // Proceed with further request handling
}
catch (ArgumentNullException ex)
{
    // Handle the case where the request is null
    Console.WriteLine(ex.Message);
}
catch (ArgumentOutOfRangeException ex)
{
    // Handle the case where an invalid timeout value is provided
    Console.WriteLine(ex.Message);
}
catch (WebException ex)
{
    // Handle web-specific exceptions, such as timeouts
    Console.WriteLine($"WebException caught: {ex.Message}");
}
catch (Exception ex)
{
    // Handle any other exceptions that may occur
    Console.WriteLine($"An error occurred: {ex.Message}");
}
