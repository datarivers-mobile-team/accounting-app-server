export enum FormFieldTypes {
	input,
	// file,
	// select,
	// multiSelect,
	// color,
}
export type FieldsType = {
	fieldType: FormFieldTypes;
	name: string;
	type?: string;
	placeholder?: string;
	required?: boolean;
	[inp: string]: any;
}[];

export const LOGIN_FIELDS: FieldsType = [
	{
		fieldType: FormFieldTypes.input,
		name: 'email',
		type: 'email',
		placeholder: 'Email',
		required: true,
	},
	{
		fieldType: FormFieldTypes.input,
		name: 'password',
		type: 'password',
		placeholder: 'Password',
		required: true,
	},
];
