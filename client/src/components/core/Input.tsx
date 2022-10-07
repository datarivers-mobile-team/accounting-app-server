type TextInputProps = {
	className?: string;
	[inp: string]: any;
};

export const TextInput = ({ className, ...others }: TextInputProps) => {
	return (
		<input
			className={'block input input-bordered w-full ' + className}
			autoCorrect="false"
			spellCheck="false"
			{...others}
		/>
	);
};
