INCLUDE <ASMInclude.asm>

public CommMain
public CommMain_End
public CommMain_Bindings

.DATA

CommMain_Bindings	DWORD		0
bind0				DWORD		b0+1
bind1				DWORD		b1+1
bind2				DWORD		b2+1

.CODE

CommMain:
	mov ecx, ebp
	push eax
	movss dword ptr [esp], xmm1
	pushad

b0:	call NO_SYMBOL				; CommInit
	test eax, eax
	jne d0
b1:	mov esi, NO_ADDRESS
	mov ebp, [esi+18]
	push [esi+10]
	push 00
	push 38
	call dword ptr[ebp+00]		; OpenProcess
	mov ebx, eax
	mov edi,[esi+14]
	lea eax, [esi+40]
	push 00
	push 80
	push eax
	push edi
	push ebx
	call dword ptr[ebp+04]		; ReadProcessMemory
	lea eax, [esi+40]
	lea eax, [eax+80]
	lea ecx, [edi+80]
	mov [eax], 00000001
	push 00
	push 20
	push eax
	push ecx
	push ebx
	call dword ptr [ebp+08]		; WriteProcessMemory
	push ebx
	call dword ptr [ebp+0C]		; CloseHandle
	nopx 5
	nopx 5						; CameraControlMain
d0:	popad
b2:	call NO_SYMBOL				; UpdateGameState
	push eax
	nopx 5						; ColorAdjustments
	pop eax
	ret
CommMain_End:

END