import { TestBed } from '@angular/core/testing';

import { DeptservService } from './deptserv.service';

describe('DeptservService', () => {
  let service: DeptservService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DeptservService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
