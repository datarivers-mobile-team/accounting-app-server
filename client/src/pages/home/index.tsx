import { AppLayout } from 'layouts';
import { Route, Routes } from 'react-router-dom';
import DashboardPage from './dashboard';

const AppRouter = () => {
	return (
		<Routes>
			<Route path="" element={<AppLayout />}>
				<Route path="/" element={<DashboardPage />} />
			</Route>
		</Routes>
	);
};

export default AppRouter;