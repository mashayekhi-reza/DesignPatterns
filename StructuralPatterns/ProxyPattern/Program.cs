using ProxyPattern.Example;
using ProxyPattern.Structural;

Console.WriteLine("Proxy Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nProxy Pattern Structural Implementation\n");

	var proxy = new Proxy();
	Console.WriteLine("Proxy Request");
	proxy.Request();

	Console.WriteLine("\nProxy Pattern Lazy Initialization\n");

	var lazyProxy = new LazyProxy();
	Console.WriteLine("Proxy Request");
	lazyProxy.Request();

	Console.WriteLine("\nProxy Pattern Thread Safe Lazy Initialization\n");

	var threadSafeLazyProxy = new ThreadSafeLazyProxy();
	Console.WriteLine("Proxy Request");
	threadSafeLazyProxy.Request();

	Console.WriteLine("\nProxy Chain\n");

	var chainProxyAdminUser = new ChainProxy("Admin");
	Console.WriteLine("Proxy Request");
	chainProxyAdminUser.Request();

	var chainProxyNormalUser = new ChainProxy("NormalUser");
	Console.WriteLine("Proxy Request");
	chainProxyNormalUser.Request();
}

static void ExampleImplementation()
{
	Console.WriteLine("\nProxy Pattern Example Implementation\n");

	var chainDocumentProxyWithAccess = new DocumentAccessControlProxy("user");
	chainDocumentProxyWithAccess.DisplayDocument();

	var chainDocumentProxyWithoutAccess = new DocumentAccessControlProxy("viewer");
	chainDocumentProxyWithoutAccess.DisplayDocument();

}
