# jatim
Just another tiny in-memory message bus.

## Expected result

I would like this to work in the following way:

### Subscriber

... is just a class implementing Jatim interface.

```c#
public class TaskNotificationMailer : ISubscriber<UserTask>
{
  protected IMailSender _mailSender;

  public TaskNotificationMailer(IMailSender mailSender)
  {
    this._mailSender = mailSender;
  }
  
  public async Task Handle(Envelope<UserTask> taskToMail)
  {
    await this._mailSender.Send(
      new MailMessage {
        Body = taskToMail.Message.Description,
        To = taskToMail.Message.User.Email });
  }
}
```

### Publishing messages

Publisher finds subscribers for the type and instantiates them using DI container.

```c#
MessageBus.Publish(new UserTask { Severity = SeverityEnum.High, Description = "...", User = user });
```

... and that's all I aspire to. It won't be a big library.
