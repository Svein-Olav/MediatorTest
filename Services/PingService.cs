using MediatR;
public class PingService : IRequest<string> {};

public class PingHandler: IRequestHandler<PingService, string>
{
    public Task<string> Handle(PingService request, CancellationToken cancellationToken)
    {
        return Task.FromResult("Hello from server");
    }
}