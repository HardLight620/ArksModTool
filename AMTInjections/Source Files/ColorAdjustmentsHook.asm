INCLUDE <ASMInclude.asm>

public ColorAdjustmentsHook
public ColorAdjustmentsHook_End
public ColorAdjustmentsHook_Bindings

.DATA

ColorAdjustmentsHook_Bindings	DWORD		0
bind0							DWORD		b0+1

.CODE

ColorAdjustmentsHook:
b0:	call NO_SYMBOL
ColorAdjustmentsHook_End:

END