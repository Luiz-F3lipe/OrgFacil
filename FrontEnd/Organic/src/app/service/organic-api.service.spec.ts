import { TestBed } from '@angular/core/testing';

import { OrganicApiService } from './organic-api.service';

describe('OrganicApiService', () => {
  let service: OrganicApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OrganicApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
