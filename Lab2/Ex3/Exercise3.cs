using System;
namespace Lab2.Ex3
{
	public class Exercise3
	{
        public class SystemResource
        {
            public string Name { get; private set; }
            public bool IsInUse { get; private set; }

            public SystemResource(string name)
            {
                Name = name;
                IsInUse = false;
            }

            public bool Acquire()
            {
                if (!IsInUse)
                {
                    IsInUse = true;
                    return true;
                }
                return false;
            }

            public void Release()
            {
                IsInUse = false;
            }
        }

        public class AskResource
        {
            private List<(SystemResource Resource, int Duration)> _resourceRequests;

            public AskResource()
            {
                _resourceRequests = new List<(SystemResource, int)>();
            }

            public void AddResourceRequest(SystemResource resource, int duration)
            {
                _resourceRequests.Add((resource, duration));
            }

            public void AcquireResource()
            {
                foreach (var request in _resourceRequests)
                {
                    while (!request.Resource.Acquire())
                    {
                        Console.WriteLine($"{request.Resource.Name} is currently in use. Waiting...");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine($"Acquired {request.Resource.Name} for {request.Duration} seconds.");
                    Thread.Sleep(request.Duration * 1000);
                    request.Resource.Release();
                    Console.WriteLine($"Released {request.Resource.Name}.");
                }
            }
        }
    }
}

