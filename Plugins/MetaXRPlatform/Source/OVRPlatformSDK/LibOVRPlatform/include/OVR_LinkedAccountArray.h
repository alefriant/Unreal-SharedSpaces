// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

#ifndef OVR_LINKEDACCOUNTARRAY_H
#define OVR_LINKEDACCOUNTARRAY_H

#include "OVR_Platform_Defs.h"
#include "OVR_LinkedAccount.h"
#include <stddef.h>

/// Represents a paginated list of ovrLinkedAccountHandle elements
typedef struct ovrLinkedAccountArray *ovrLinkedAccountArrayHandle;

/// Access the indexed element in this list.
OVRP_PUBLIC_FUNCTION(ovrLinkedAccountHandle) ovr_LinkedAccountArray_GetElement(const ovrLinkedAccountArrayHandle obj, size_t index);

/// The number of elements contained within this list. This is not equal to the
/// total number of elements across multiple pages.
OVRP_PUBLIC_FUNCTION(size_t) ovr_LinkedAccountArray_GetSize(const ovrLinkedAccountArrayHandle obj);


#endif
