#pragma once

#ifdef REQUESTS_WRAPPER_LIBRARY_API_ENABLED
#define REQUESTS_WRAPPER_LIBRARY_API __declspec(dllexport)
#else
#define REQUESTS_WRAPPER_LIBRARY_API __declspec(dllimport)
#endif
