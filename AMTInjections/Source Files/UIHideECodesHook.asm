INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public UIHideECodesHook
public UIHideECodesHook_End
public UIHideECodesHook_Bindings

.DATA

UIHideECodesHook_Bindings	DWORD		0
bind0						DWORD		b0+1

.CODE

UIHideECodesHook:
	push edi
	push [ebp+08]
b0:	call NO_SYMBOL
	nop
UIHideECodesHook_End:

END