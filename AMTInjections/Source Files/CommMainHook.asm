INCLUDE <ASMInclude.asm>

public CommMainHook
public CommMainHook_End
public CommMainHook_Bindings

.DATA

CommMainHook_Bindings	DWORD		0
bind0					DWORD		b0+1

.CODE

CommMainHook:
	nopx 8
b0:	call NO_SYMBOL
CommMainHook_End:

END