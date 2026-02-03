using OpenAI;
using OpenAI.Chat;

Console.WriteLine("AI Question Taker - Michael Waiman");

string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

ChatClient client = new(model: "gpt-4o", apiKey: apiKey);

while (true)
{
	Console.Write("Enter a question (or type exit): ");
	string q = Console.ReadLine();

	if (q == null) return;
	if (q.Trim().ToLower() == "exit") break;
	if (q.Trim().Length == 0) continue;

	ChatCompletion completion = client.CompleteChat(q);
	Console.WriteLine("Answer: " + completion.Content[0].Text);
}

Console.WriteLine("Done - Michael Waiman");
