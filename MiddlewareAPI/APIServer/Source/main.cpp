#include <iostream>

#include "Core/HttpRequestsWrapper.h"

using namespace requests_library::core;

int main()
{
	HttpRequestsWrapper wrapper;

	wrapper.TestCall();

	return 0;
}